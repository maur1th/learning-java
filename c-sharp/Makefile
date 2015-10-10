CC 			= mcs
SRC_DIR		= ./srcs/
TARGETS		= Hello.exe \
			  MethodParameters.exe \
			  MethodOverridingHiding.exe

all: $(TARGETS)

%.exe: $(SRC_DIR)%.cs
	$(CC) -out:$@ $<

fclean:
	/bin/rm -f *.exe

re: fclean all
