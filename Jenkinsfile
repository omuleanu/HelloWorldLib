pipeline {
  agent any
  stages {
    stage('Clean Workspace'){
      steps {
        cleanWs()
      }
    }

    stage('Print Branch Name') {
       steps {
        echo "Current branch name: ${env.BRANCH_NAME}"
      }
    }
    
    stage('Checkout Code') {
      steps {
        git branch: 'jenkins', 
        url: 'https://github.com/omuleanu/HelloWorldLib.git', 
        credentialsId: 'githubHelloPAT'
      }
    }
    
    stage('Restore NuGet Packages') {
      steps {        
        script {
          bat 'cd HelloWorldLib && dotnet restore HelloWorldLib.sln'
        }
      }
    }
    
    stage('Build Solution') {
      steps {
        bat 'dotnet build  HelloWorldLib.sln --configuration Release'
      }
    }

  }
}