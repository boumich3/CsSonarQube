pipeline {
    agent none
    stages {
        stage('SonarQube Scanner') { 
            agent {
                docker {
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