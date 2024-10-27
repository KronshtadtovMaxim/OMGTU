import scipy
import sympy as sp
from scipy import special
from scipy import integrate
import numpy as np
from scipy import optimize
x = sp.Symbol('x')
y = 2/(sp.sin(x) + 4)
derivative = sp.diff(y, x)
derivative2 = sp.diff(y,x, 2)
print("Производная функции y по x: ", derivative)
print("Второя производная функции y по x: ", derivative2)
print()
y1 = lambda x: 2/(sp.sin(x)+4)
a = scipy.integrate.quad(y1, 3, 6)
print("Значение определенного интеграла y1 в пределах от 3 до 6: ", a[0])

print()
integral = sp.integrate(y, x)
print("Неопределенный интеграл от функции y: ",integral)

print()
def func(x):
    x1, x2 = x
    return (x1 - 4)**2 + (x2 - 2)**2

ogr = [
    {'type': 'ineq', 'fun': lambda x: 4*x[0] + 2*x[1] - 11},  # 4x1 + 2x2 >= 11
    {'type': 'ineq', 'fun': lambda x: -2*x[0] + 7}            # -2x1 >= 7
]
x0 = np.array([0,0]) # все переменные неотрициательны
result = scipy.optimize.minimize(func, x0, constraints=ogr)
print("Оптимальное решение: ", result.x)
print("Минимальное значение функции: ", result.fun)