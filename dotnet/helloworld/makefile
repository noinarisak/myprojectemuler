# dotnet Core CLR make file
CC=dnu
EXECULABLE=dnx
# ENVIRONMENT=dnvm
# ENVIRONMENT_VERSION=1.0.0-rc2-16357

all: run

build: clean
	$(CC) build

restore:
	$(CC) restore

run: restore
	$(EXECULABLE) run

clean:
	rm -r bin/

# WIP: Can not get the dnvm command to execute in make, probably have to do with 
# 		PATH to dnvm
# setup:
# 	$(ENVIRONMENT) list
# 	# dnvm use -r coreclr -arch x64 1.0.0-rc2-16357 -p
# 	# $(ENVIRONMENT) use -r coreclr -arch x64 $(ENVIRONMENT_VERSION)
