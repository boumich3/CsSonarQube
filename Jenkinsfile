pipeline {
    agent none 
    stages {
        stage('SonarQube Scanner') { 
            agent {
                docker { image 'boumich3/sonarqubescanner-msbuild' }
            }
            steps {
                withSonarQubeEnv('My SonarQube Server') {
                    sh 'SonarScanner.MSBuild.exe begin /k:"SonarQubeCs_Test" /n:"SonarQubeCs" /d:sonar.language="cs"'
                    sh 'MSBuild.exe SonarQubeCs.sln /t:rebuild'
                    sh 'SonarScanner.MSBuild.exe end'
                }
            }
        }
        stage("Quality Gate") {
            steps {
                timeout(time: 1, unit: 'HOURS') {
                    waitForQualityGate abortPipeline: true
                }
            }
        }
    }
}