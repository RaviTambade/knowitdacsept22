## Continuous Integration/Continuous Delivery

Continuous Integration/Continuous Delivery (CI/CD) is a holistic DevOps process that focuses on creating a compatible blend between the development cycle and the operations process. This is done by automating workflows and rolling out automatic updates to improve ROI. The CI/CD pipeline implementation is the backbone of the entire DevOps paradigm and facilitates the process of introducing the product to the marketplace faster than ever before. 


### Continuous Integration(CI)

Continuous Integration(CI), which was first proposed as a term by Gary Booch, integrates the source code with the repository. This facilitates the developers to carry out the development process in a quick and sophisticated manner.

CI is not entirely an essential prerequisite required for creating a stable software product. However, it definitely serves an important role when developing software products or components that require frequent changes. Furthermore, it also ensures that all the components of an application are integrated properly. 

Continuous Integration is a software development method where team members integrate their work at least once a day. In this method, every integration is checked by an automated build to detect errors. This concept was first introduced over two decades ago to avoid “integration hell,” which happens when integration is put off till the end of a project.

In Continuous Integration after a code commit, the software is built and tested immediately. In a large project with many developers, commits are made many times during a day. With each commit code is built and tested. If the test is passed, build is tested for deployment. If the deployment is a success, the code is pushed to Production. This commit, build, test, and deploy is a continuous process, and hence the name continuous integration/deployment.

In the SDLC, CI mainly covers the Source and Build phases. A CI pipeline typically involves these steps:      

.Detect changes in the code 
.Analyze the quality of the source code
.Build
.Execute all unit tests
.Execute all integration tests
.Generate deployable artifacts
.Report status

If any of the above steps fail, the integration stops immediately, and the team is notified about the result. 

### Continuous Delivery(CD)

Continuous Delivery (CD), on the other hand, is a set of software development practices that ensures the deployment of code to production while performing efficient testing in the process. Precisely speaking, CD starts where CI ends. Continuous Delivery is responsible for pushing the code to the testing environment where different tests such as system testing, unit testing, and integration testing are performed.

A typical CI/CD pipeline works in 4 phases that are listed below:       

- Phase 1: Commit - This is the actual phase where developers commit changes to the code.
- Phase 2: Build – In this phase, the source code is integrated into the build from the repository. 
- Phase 3: Test Automation - This step is an integral part of any CI/CD pipeline. The source code previously integrated into the build is subjected to a systematic cycle of testing.  
- Phase 4: Deploy - The tested version is finally sent for deployment in this phase.

While Continuous Integration covers the commit and build stages, Continuous Delivery, on the other hand, ensures the process automation as well as testing till the deployment phase.

### How Do You Create Your CI/CD Pipeline With Jenkins?

Jenkins is one of the most widely used open-source CI/CD DevOps tools. It enables developers to implement CI/CD pipelines within the development environment in a comprehensive manner. Jenkins is written in Java and supports various version control tools including Git and Maven.

Its popularity is based on the fact that Jenkins is an open source repository of rich integrations and plugins that are well documented and extensible, based on an extended community of developers who have developed hundreds of plugins to accomplish almost any task. 

Jenkins runs on the server and requires constant maintenance and updates. The availability of Jenkins as a cross-platform tool for Windows, Linux, and various operating systems makes it stand out among other DevOps tools. Moreover, it can easily be configured using CLI or GUI.

#### Why Use CI/CD with Jenkins?

The list of benefits of using CI/CD with Jenkins is a detailed one. The three main ones are:

1. Costs
While implementing CI/CD with Jenkins, developers and the DevOps team don’t need to worry about the additional procurement costs involved in setting up code pipelines, as Jenkins is free and open source. This simply means that they no longer have to get spending approval from management. As far as cloud and infrastructure costs are concerned, these costs can be optimized as well by efficiently utilizing the resources available and implementing the Infrastructure as Code (IAC) approach using Jenkins. 

2. Plugins
Another remarkable feature that highlights Jenkins’ value is the extended variety of Jenkins plugins available in Jenkins. With this diverse range, users of different cloud providers can feasibly utilize CI processes via Jenkins in a significantly lesser time. Moreover, Jenkins also provides a default list of common tools and services that can be implemented either on-premises or on the cloud. Top Jenkins plugins include Dashboard View, Test Analysis Plugins, and Build Pipeline Plugins.

3. Open Source
Jenkins, with its long history of CI/CD practices, was introduced in the year 2011. Its availability on the open-source platform provides it an edge over other tools used for the same purpose. Numerous developers, community contributors, and users actively participate in the open-source platform to maintain Jenkin’s functionality as an open-source product.

#### Configuring Automated CI/CD with Jenkins & GitHub — Step by Step

Configuring automated CI/CD with Jenkins and GitHub is a simple and straightforward process and can help automate the entire workflow. Integrating Jenkins with GitHub enables the developers to pull the source code from any Git repository in a hassle-free manner.

Furthermore, GitHub also supports bi-directional integration, which will automatically initiate a trigger to Jenkins every time there is a change in the GitHub repository.

DevOps is an ever-evolving ecosystem in the development industry, and the CI/CD tools in this domain are highly critical. CI/CD practices effectively handle the misalignment between developers and the operational team. There are several tools built for this purpose in the marketplace today, but Jenkins holds an established position in the industry as well as a promising future ahead of it because of its open-source benefits and a wide range of plugins. Furthermore, it integrates well with GitHub allowing productivity and flexibility in the DevOps cycle.


<a href="https://www.jenkins.io/solutions/pipeline/"> Jenkins Pipeline</a>