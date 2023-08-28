# AppMVCDocker

-Publish project

-docker build -t appmvcdocker:v1 .

-docker run -p 5000:80 appmvcdocker:v1

-docker run -d -p 5001:80 appmvcdocker:v1

-docker run -d --name mymvcappcontainer -p 5002:80 appmvcdocker:v1
