@echo off

echo ɾ��output�е�ԭ�нű���pb����...
echo ----------------------------------------
echo.
del .\output\datatable_cs\ /F /Q
del .\output\exporter\ /F /Q
del .\output\pbbytes\ /F /Q
del .\output\proto\ /F /Q
del .\output\protoCs\ /F /Q

echo ��ʼ��ȡ�������...
echo ----------------------------------------
ExcelTool.exe
echo.

if %ERRORLEVEL% NEQ 0 (
	echo ExcelTool Excute Failed...
	pause
	EXIT /B 0
)



echo ��ʼ����proto csharp�����ļ�...
echo ----------------------------------------
for %%i in (./output/proto/*.proto) do (
	protoc --csharp_out=./output/protoCs ./output/proto/%%i
	echo %%i���ɳɹ�
)
echo.

echo ����proto csharp�����ļ���ExcelProtoDataTool...
echo ----------------------------------------
copy .\output\protoCs\*.cs ..\ExcelProtoDataTool\ProtoCS /Y
echo.


echo ����proto �������ļ���ExcelProtoDataTool...
echo ----------------------------------------
copy .\output\exporter\*.cs ..\ExcelProtoDataTool\ProtoExport /Y
echo.

echo ��ʼ���� ExcelProtoDataTool...
echo ----------------------------------------
msbuild ..\ExcelProtoDataTool/ExcelProtoDataTool.csproj 

if %ERRORLEVEL% NEQ 0 (
	echo ExcelProtoDataTool ����ʧ��...
	pause
	EXIT /B 0
)

echo ExcelProtoDataTool �������...
echo.


echo ��ʼ����pb����...
echo ----------------------------------------
ExcelProtoDataTool.exe

if %ERRORLEVEL% NEQ 0 (
	echo pb���ݵ���ʧ��...
	pause
	EXIT /B 0
)

echo pb���ݵ������

echo ��ʼ���Ƶ�Unity����...
echo ----------------------------------------
echo.

echo ɾ��ԭ��proto����ͼ����ļ�
del ..\..\WDGame\Assets\Scripts\Proto\ProtoDef\ /F /Q
del ..\..\WDGame\Assets\Scripts\Table\ /F /Q
del ..\..\WDGame\Data\TableData\ /F /Q
echo ----------------------------------------
echo.

echo �����µ�proto����ͼ����ļ�
copy .\output\protoCs\*.cs ..\..\WDGame\Assets\Scripts\Proto\ProtoDef /Y
copy .\output\datatable_cs\*.cs ..\..\WDGame\Assets\Scripts\Table /Y
copy .\output\pbbytes\*.bin ..\..\WDGame\Data\TableData /Y

pause