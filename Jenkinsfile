pipeline {
    agent any
    stages {
        stage('SonarQube Scanner') { 
            steps {
                withSonarQubeEnv('SonarQube') {
                    script {
                        def msBuildHome = tool "MsBuild"
                        def sqScannerMsBuildHome = tool "SonarMsBuild"

                        bat "\"${sqScannerMsBuildHome}\\SonarQube.Scanner.MSBuild.exe\" begin /k:\"optel_station\" /n:\"Optel Station\" /d:sonar.language=\"cs\" /d:sonar.verbose=true"
                        bat "\"${msBuildHome}\\MSBuild.exe\" /t:rebuild"
                        bat "\"${sqScannerMsBuildHome}\\SonarQube.Scanner.MSBuild.exe\" end"
                    }
                }
            }
        }
    }
}