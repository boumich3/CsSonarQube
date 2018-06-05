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

                        bat "\"${sqScannerMsBuildHome}\\SonarQube.Scanner.MSBuild.exe\" begin /k:\"optel_station\" /n:\"Optel Station\" /s:path=\"%CD%\\SonarQube.Analysis.xml\""
                        bat "\"${msBuildHome}\\MSBuild.exe\" /t:rebuild"
                        bat "\"%LOCALAPPDATA%\\Apps\\OpenCover\\OpenCover.Console.exe\" -output:\"%CD%\\opencover.xml\" -register:user -target:\"${vsTestHome}\\vstest.console.exe\" -targetargs:\"/Logger:trx sonar_csharp.test\\bin\\Debug\\sonar_csharp.test.dll\""
                        bat "\"${sqScannerMsBuildHome}\\SonarQube.Scanner.MSBuild.exe\" end"
                    }
                }
            }
        }
    }
}