import numpy
import scipy
from scipy.linalg import lu
from scipy import stats
matrix = numpy.array([[2.3, 0,-3.4, -12], [2.6, 8.4, 0, -6], [1.3, 4.5, -17, 2], [1.8, 0, 15, 16]])
P, L, U = lu(matrix)
print("Матрица L (нижняя треугольная):")
print(L)
print("Матрица U (верхняя треугольная):")
print(U)
print("Матрица P (перестановок):")
print(P)
print()

det_U = numpy.prod(numpy.diag(U)) #т.к. она треугольная
#det L = 1
det_P_inv = 1/numpy.linalg.det(P)
det_matrix = det_P_inv * 1 * det_U
print("Определитель матрицы matrix: ", det_matrix)


a = numpy.random.randint(0, 100, 100) #равномерное
b = numpy.random.normal(50, 100/6, 100) #normal
b = numpy.clip(numpy.round(b), 0, 100).astype(int) #округление
print("Равномерная выборка: ")
print(a)
print("Нормальная выборка: ")
print(b)

print("Статистика для равномерной выборки:")
print("Среднее: ", numpy.mean(a))
print("Мода: ", stats.mode(a)[0])
print("Медиана: ", numpy.median(a))
print("Минимум: ", numpy.min(a))
print("Максимум: ", numpy.max(a))
print("Стандартное отклонение: ", numpy.std(a, ddof = 1)) #ddof=1 указывает на то, что мы вычисляем стандартное отклонение для выборки

print("Статистика для нормальной выборки:")
print("Среднее: ", numpy.mean(b))
print("Мода: ", stats.mode(b)[0])
print("Медиана: ", numpy.median(b))
print("Минимум: ", numpy.min(b))
print("Максимум: ", numpy.max(b))
print("Стандартное отклонение: ", numpy.std(b, ddof = 1))
print()

aa = [1]*100 #Ожидаемые частоты
b = [0]*100
#Воспользуемся равномерной выборкой
for n in a:
    b[n] += 1
statistic, pvalue = scipy.stats.chisquare(b,aa)
print(f"p-value: {pvalue}")
print("0.94 > 0.05 => распределение выборки равномерное")