CC 			= mcs
SRC_DIR		= ./srcs/
TARGETS		= Hello.exe \
			  MethodParameters.exe \
			  Namespaces.exe \
			  StaticInstance.exe \
			  Inheritance.exe \
			  Polymorphism.exe \
			  MethodOverridingHiding.exe \
			  MethodOverloading.exe \
			  Properties.exe \
			  FactoryPattern.exe \
			  CompositePattern.exe \
			  StrategyPattern.exe

all: $(TARGETS)

%.exe: $(SRC_DIR)%.cs
	$(CC) -out:$@ $<

fclean:
	/bin/rm -f *.exe

re: fclean all
