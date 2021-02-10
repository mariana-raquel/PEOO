#! /bin/bash

file=$(ls -Rt */*.cs *.cs | head -n1)
echo "Executando "$file ...
mcs -out:../main.exe $file ; mono ../main.exe
