pipeline {
    agent none
    stages {
        stage('SonarQube Scanner') { 
            agent {
                docker { 
                    image 'boumich3/sonarqubescanner-msbuild'
                    label "windows" 
                }
            }
            steps {
                withSonarQubeEnv('My SonarQube Server') {
                    bat 'SonarScanner.MSBuild.exe begin /k:"SonarQubeCs_Test" /n:"SonarQubeCs" /d:sonar.language="cs"'
                    bat 'MSBuild.exe SonarQubeCs.sln /t:rebuild'
                    bat 'SonarScanner.MSBuild.exe end'
                }
            }
        }
    }
}