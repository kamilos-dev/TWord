# Set folder base
cd '../tests/TWord.Tests'

# Remove old test results
Remove-Item "TestResults" -Recurse -ErrorAction Ignore 
Remove-Item "coveragereport" -Recurse -ErrorAction Ignore 

# Generate new test result
dotnet test --collect:"XPlat Code Coverage"

# Get result Id
$testId = Get-ChildItem "TestResults" | Select-Object | %{$_.Name}

# Generate coverage
reportgenerator "-reports:TestResults\$testId\coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html

# Open coverage in default program
start "coveragereport\index.html"