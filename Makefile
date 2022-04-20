PROJDIR:=src
NETVER:=netcoreapp3.1
SYSTEM:=win-x64

release:
	dotnet publish $(PROJDIR)/discension.csproj -r $(SYSTEM) -p:PublishSingleFile=true --self-contained true \
		-p:PublishReadyToRunShowWarnings=true -p:IncludeNativeLibrariesForSelfExtract=true --configuration Release
	cp $(PROJDIR)/bin/Release/$(NETVER)/$(SYSTEM)/publish/discension.exe discension.exe
