class Component(object):
	def __init__(self, *args, **kwargs):
		pass

	def component_function(self):
		pass


class Composite(Component):
	def __init__(self, *args, **kwargs):
		super().__init__(self, *args, **kwargs)
		self._children = []

	def add_child(self, child):
		self._children.append(child)

	def remove_child(self, child):
		self._children.remove(child)

	def component_function(self):
		map(lambda x: x.component_function(), self._children)


class Leaf(Component):
	def __init__(self, *args, **kwargs):
		super().__init__(self, *args, **kwargs)

	def component_function(self):
		print("some function")


c = Composite()
l = Leaf()
l_two = Leaf()
c.add_child(l)
c.add_child(l_two)
c.component_function()
