@echo off

protoc --csharp_out=./output ./MapData.proto
echo proto�ļ����ɳɹ�

copy .\output\MapData.cs ..\Assets\Scripts\Proto

pause