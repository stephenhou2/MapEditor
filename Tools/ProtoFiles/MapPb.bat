@echo off

protoc --csharp_out=./output ./GameMapData.proto
echo proto�ļ����ɳɹ�

move .\output\GameMapData.cs ..\Assets\Scripts\Proto

pause