CC 			= mcs
SRC_DIR		= ./srcs/
TARGET		= Hello.exe \
			  MethodOverridingHiding.exe

all: $(TARGET)

%.exe: $(SRC_DIR)%.cs
	$(CC) -out:$@ $<

fclean:
	/bin/rm -f *.exe

re: fclean all
