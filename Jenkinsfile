pipeline {
    agent none
    stages {
        stage('SonarQube Scanner') { 
            agent {
                label 'windows'
            }
            steps {
                withSonarQubeEnv('My SonarQube Server') {
                    echo 'test'
                }
            }
        }
    }
}