# Set folder base
$testPath '../'

# Remove old test results
Remove-Item Join-Path -Path $testPath -ChildPath "TestResults" -Recurse -ErrorAction Ignore 
Remove-Item Join-Path -Path $testPath -ChildPath "coveragereport" -Recurse -ErrorAction Ignore 

# Generate new test result
dotnet test "$testPath" --collect:"XPlat Code Coverage"

# Get result Id
$testId = Get-ChildItem Join-Path -Path $testPath -ChildPath "TestResults" | Select-Object | %{$_.Name}

# Generate coverage
$coverageResult Join-Path -Path $testPath -ChildPath "TestResults\$testId\coverage.cobertura.xml"
$outputResultDir Join-Path -Path $coverageResult -ChildPath "coveragereport"
reportgenerator "-reports:$coverageResult" "-targetdir:$outputResultDir" -reporttypes:Html

# Open coverage in default program
start "$outputResultDir\index.html"