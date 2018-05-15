pipeline {
    agent none
    stages {
        stage('SonarQube Scanner') { 
            agent {
                label 'windows'
            }
            steps {
                bat 'docker image ls'
            }
        }
    }
}