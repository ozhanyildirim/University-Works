


VPATH= ./src

CXXFLAGS = g++ -c -I "./include" -o		

all:odev calistir

odev:CIRCULARDOUBLYLINKEDLIST.o odev.o
	g++ ./lib/CIRCULARDOUBLYLINKEDLIST.o ./lib/odev.o -o ./bin/odev

CIRCULARDOUBLYLINKEDLIST.o:CIRCULARDOUBLYLINKEDLIST.cpp	
	$(CXXFLAGS) ./lib/CIRCULARDOUBLYLINKEDLIST.o $<

odev.o:odev.cpp
	 $(CXXFLAGS) ./lib/odev.o $<

calistir:
	./bin/odev
