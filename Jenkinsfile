pipeline {
  agent any
  stages {
    stage('Clean Workspace'){
      steps {
        cleanWs()
      }
    }
    
    stage('Checkout Code') {
      steps {
        git branch: 'master', 
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
        bat 'msbuild /p:Configuration=Release HelloWorldLib\\HelloWorldLib.sln'
      }
    }

  }
}