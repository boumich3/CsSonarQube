pipeline {
    agent none
    stages {
        stage('SonarQube Scanner') { 
            agent {
                docker { 
                    image 'microsoft/dotnet-framework'
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