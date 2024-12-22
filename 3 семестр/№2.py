import scipy
import sympy as sp
from scipy import integrate
import numpy as np
from scipy.optimize import minimize, NonlinearConstraint
import scipy.misc as sc

def f(x):
    return 2 / (sp.sin(x) + 4)
derivative = sc.derivative(f, 2.0, dx=1e-6)
derivative2 = sc.derivative(f, 2.0, dx=1e-6, n=2)
print("Производная функции y по x: ", derivative)
print("Вторая производная функции y по x: ", derivative2)
print()

x = sp.symbols('x')
y = 2/(sp.sin(x)+4)
der = sp.diff(y,x)
print("Символьное представление производной: ", der)
print()
y1 = lambda x: 2/(sp.sin(x)+4)
a = scipy.integrate.quad(y1, 3, 6)
print("Значение определенного интеграла y1 в пределах от 3 до 6: ", a[0])

print()
abc = sp.integrate(y,x)
print(f"Неопределенный интеграл от функции: {abc} + C")

print()
def func(x):
    x1, x2 = x
    return (x1 - 4)**2 + (x2 - 2)**2
#Ограничения
def constraint1(x):
    return 4 * x[0] + 2 * x[1]

def constraint2(x):
    return -2 * x[0]
a = NonlinearConstraint(constraint1, 11, np.inf); #NonlinearConstraint(constraint1, 11 (7), np.inf) создает объект ограничения, где constraint1 — это функция,
b = NonlinearConstraint(constraint2, 7, np.inf); #которая должна быть неотрицательной, а 11 или 7 и np.inf указывают на то, что функция должна быть больше 11 или 7.
x0 = np.array([0,0]) # так как все переменные неотрицательны, начинаем поиск с x1 = 0 и x2 = 0
result = minimize(func, x0, constraints=[a, b])
print("Оптимальное решение: ", result.x)
print("Минимальное значение функции: ", result.fun)
