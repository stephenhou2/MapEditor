@echo off

protoc --csharp_out=./output ./output/TableData.proto
echo proto�ļ����ɳɹ�

copy .\output\TableData.cs ..\Assets\Scripts\Proto