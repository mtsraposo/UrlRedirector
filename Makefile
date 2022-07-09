publish:
	dotnet publish
	cd bin/Debug/netcoreapp3.1/publish && zip -r ../publish-$V.zip . && cd ../../../..