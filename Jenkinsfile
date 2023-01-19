pipeline {
    agent any
        stages {
            stage('Cleanup') {
                steps {
                    sh 'docker kill $(docker ps -q)'
                    sh 'docker system prune -f'
                }
            }
            stage('Build') {
                steps {
                    sh 'docker build -t aspnetapp .'
                }
            }
            stage('Deploy') {
                steps {
                    sh 'docker run --rm -p 5000:80 --name aspnetcore_sample aspnetapp'
                }
            }
    }
}