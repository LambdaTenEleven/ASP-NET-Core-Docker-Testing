## Description

This is an ASP .NET Core app that shows a random cat picture every time you reload the page.

I made this to test Docker.

API used: https://api.thecatapi.com/v1/images/search

## Build and run

To run this project, clone the repository:

```shell
git clone https://github.com/ArianTerra/ASP-NET-Core-Docker-Testing
```

Then build and run the app in Docker:

```shell
docker build -t aspnetapp .
docker run -it --rm -p 5000:80 --name aspnetcore_sample aspnetapp
```

The app will be available at http://localhost:5000