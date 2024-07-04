dotnet test --logger "console;verbosity=detailed"
findstr /s /R /C:"^[ ]*//" /C:"/\*" /C:"\*/" *.cs | findstr Assert
grep -r --include="*.cs" -B3 Assert.Inconclusive *