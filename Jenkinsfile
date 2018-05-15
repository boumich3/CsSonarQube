pipeline {
    agent none
    stages {
        stage('SonarQube Scanner') { 
            agent {
                docker { 
                    image 'boumich3/sonarqubescanner-msbuild'
                    label 'windows'
                }
            }
            steps {
                withSonarQubeEnv('My SonarQube Server') {
                    echo 'test'
                }
            }
        }
    }
}