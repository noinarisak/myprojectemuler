# dotnet Core CLR make file
CC=dnu
EXECULABLE=dnx

all: run

build: clean
	$(CC) build

restore: clean
	$(CC) restore

run:
	$(EXECULABLE) run

clean:
	rm -r bin/