def pipeline

env.AppName="SeedProject"

node('master') {
	  switch (env.BRANCH_NAME) {
			case ~/^PR.*/:
			    echo " loading verify-pipeline ${env.BRANCH_NAME}"
				dir("D:\\Workspace\\KKM\\pr\\${env.AppName}\\${env.BRANCH_NAME}\\${env.BUILD_ID}") {	
				stage("Checkout Code")
				{
					checkout scm
				}
				validateCode()	
				}
                break            
            default :
                echo "No pipelines configured for branch ${env.BRANCH_NAME}, halting"
                break
     }
	 echo "Running ${env.BRANCH_NAME} -- ${env.BUILD_ID} on ${env.JENKINS_URL}"	 
}


def validateCode()
{
	bat 'cd devOps\\\\scripts'
	stage("Build Code")
	{
		bat '''cd devOps\\scripts
		call Build.cmd nosonar noutc nocoverage'''
	}
	stage("Unit test")
	{
		bat '''cd devOps\\scripts
		call Build.cmd nosonar nocoverage'''
	}
	stage("sonar Run")
	{
		bat '''cd devOps\\scripts
		call Build.cmd noutc'''
	}
}
