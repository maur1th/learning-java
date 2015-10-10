# **************************************************************************** #
#                                                                              #
#                                                         :::      ::::::::    #
#    Makefile                                           :+:      :+:    :+:    #
#                                                     +:+ +:+         +:+      #
#    By: tmaurin <tmaurin@student.42.fr>            +#+  +:+       +#+         #
#                                                 +#+#+#+#+#+   +#+            #
#    Created: 2015/09/21 10:13:22 by tmaurin           #+#    #+#              #
#    Updated: 2015/09/25 15:26:24 by tmaurin          ###   ########.fr        #
#                                                                              #
# **************************************************************************** #

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
