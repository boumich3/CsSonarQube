pipeline {
    agent any
    stages {
        stage('SonarQube Scanner') { 
            steps {
                withSonarQubeEnv('SonarQube') {
                    script {
                        def msBuildHome = tool "MsBuild"
                        def sqScannerMsBuildHome = tool "SonarMsBuild"
                        def vsTestHome = tool "VsTest"
                        def openCoverHome = "C:\\users\\boumich3\\AppData\\Local\\Apps\\OpenCover"

                        bat "\"${sqScannerMsBuildHome}\\SonarQube.Scanner.MSBuild.exe\" begin /k:\"optel_station\" /n:\"Optel Station\" /s:\"%CD%\\SonarQube.Analysis.xml\" /d:sonar.cs.vstest.reportsPaths=\"TestResults\\*.trx\" /d:sonar.cs.opencover.reportsPath=\"opencover.xml\""
                        bat "\"C:\\nuget\\nuget.exe\" restore \"%CD%\\sonar_csharp.sln\""
                        bat "\"${msBuildHome}\\MSBuild.exe\" /t:rebuild"
                        bat "\"${openCoverHome}\\OpenCover.Console.exe\" -output:\"%CD%\\opencover.xml\" -register:user -target:\"${vsTestHome}\\vstest.console.exe\" -targetargs:\"/Logger:trx sonar_csharp.test\\bin\\Debug\\sonar_csharp.test.dll\""
                        bat "\"${sqScannerMsBuildHome}\\SonarQube.Scanner.MSBuild.exe\" end"
                    }
                }
            }
        }
    }
}