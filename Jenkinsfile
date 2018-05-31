pipeline {
    agent any
    stages {
        stage('SonarQube Scanner') { 
            steps {
                withSonarQubeEnv('SonarQube') {
                    script {
                        def msBuildHome = tool "MsBuild"
                        def sqScannerMsBuildHome = tool "SonarMsBuild"

                        bat "\"${sqScannerMsBuildHome}\\SonarScanner.MSBuild.exe\" begin /k:\"sonar_cs\" /n:\"sonar_csharp\" /d:sonar.language=\"cs\" /d:sonar.verbose=true /d:sonar.login=\"4014dfa6e98bcbc9d961ee8819302c84abf571f6\" /d:sonar.host=\"http://localhost:9000\""
                        bat "\"${msBuildHome}\\MSBuild.exe\" /t:rebuild"
                        bat "\"${sqScannerMsBuildHome}\\SonarScanner.MSBuild.exe\" end /d:sonar.login=\"4014dfa6e98bcbc9d961ee8819302c84abf571f6\""
                    }
                }
            }
        }
    }
}