pipeline {
    agent any
    stages {
        stage('SonarQube Scanner') { 
            steps {
                withSonarQubeEnv('SonarQube') {
                    script {
                        def msBuildHome = tool "MsBuild"
                        def sqScannerMsBuildHome = tool "SonarMsBuild"

                        bat "\"${sqScannerMsBuildHome}\\SonarScanner.MSBuild.exe\" begin /k:\"Sonar C#\" /n:\"sonar_cs\" /d:sonar.language=\"cs\""
                        bat "\"${msBuildHome}\\MSBuild.exe\" sonar_csharp.sln /t:rebuild"
                        bat "\"${sqScannerMsBuildHome}\\SonarScanner.MSBuild.exe\" end"
                    }
                }
            }
        }
    }
}