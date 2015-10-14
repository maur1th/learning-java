class Vec:
	def __init__(self, labels, function):
		self.D = labels
		self.f = function

def zero_vec(D): return Vec(D, {})

def setitem(v, d, val): v.f[d] = val

def getitem(v, d): return v.f.get(d, 0)

def list2vec(L): return Vec(set(range(len(L))), {k:x for k,x in enumerate(L)})

def list_dot(u, v): return sum([m*n for m, n in zip(u, v)])
