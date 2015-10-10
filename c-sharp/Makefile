CC 			= mcs
TARGET		= Hello.exe \
			  MethodOverridingHiding.exe
SRC_DIR		= ./srcs/

all: $(TARGET)

%.exe: $(SRC_DIR)%.cs
	$(CC) -out:$@ $<

fclean:
	/bin/rm -f *.exe

re: fclean all
