# BuildASPDotNetInAContainer
Sample used to build and test an ASP.NET Core Web app in a container

# Builder container pattern

Here's how to build the app in a container with the full .NET Core SDK, publish, export and then import in a smaller runtime container image:

1. `cd BuildOptimizedImages\src\Web`
2. `$image_id = docker build -q .`
3. `$container_id = docker create $image_id.split(":")[1]`
4. `$tmp_folder_name = [System.IO.Path]::Combine([System.IO.Path]::GetTempPath() + [System.IO.Path]::GetRandomFileName())`
5  `mkdir $tmp_folder_name`
7. ``docker cp $container_id`:/out $tmp_folder_name``
8. `docker rm $container_id`
9. `docker build -t app $tmp_folder_name\out`
10. `Remove-Item -Recurse -Force $tmp_folder_name`
11 `docker run app`
