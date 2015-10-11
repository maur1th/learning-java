CC 			= mcs
SRC_DIR		= ./srcs/
TARGETS		= Hello.exe \
			  MethodParameters.exe \
			  Namespaces.exe \
			  MethodOverridingHiding.exe \
			  MethodOverloading.exe

all: $(TARGETS)

%.exe: $(SRC_DIR)%.cs
	$(CC) -out:$@ $<

fclean:
	/bin/rm -f *.exe

re: fclean all
