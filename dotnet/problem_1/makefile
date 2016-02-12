# dotnet Core CLR make file
CC=dnu
EXECULABLE=dnx

all: run

build: clean
	$(CC) build

restore:
	$(CC) restore

run: restore
	$(EXECULABLE) run

clean:
	rm -r bin/