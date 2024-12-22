import numpy
import scipy
from scipy.linalg import lu
from scipy import stats
def fix(matrix):
    for row in matrix:
        print(row)
    return ""
numpy.set_printoptions(precision = 2, suppress = True)
matrix = numpy.array([[2.3, 0,-3.4, -12], [2.6, 8.4, 0, -6], [1.3, 4.5, -17, 2], [1.8, 0, 15, 16]])
with numpy.printoptions(precision=2, suppress=True, formatter={'all': lambda x: f'{x:0.2f}'}):
    print(fix(matrix))
    P, L, U = lu(matrix)
    print("Матрица L (нижняя треугольная):")

    print(fix(L))
    print("Матрица U (верхняя треугольная):")
    print(fix(U))
    print("Матрица P (перестановок):")
    print(fix(P))
    print()

det_U = numpy.prod(numpy.diag(U)) #произведение элементов по главной диагонали (поиск определителя в диагональной матрице)
#det L = 1
det_P_inv = 1/numpy.linalg.det(P)
det_matrix = det_P_inv * 1 * det_U
print("Определитель матрицы matrix:", det_matrix)
print()

a = numpy.random.randint(0, 100, 100) #равномерное
b = numpy.random.normal(50, 20, 100) #normal
b = numpy.clip(numpy.round(b), 0, 100).astype(int) #округление
print()
print("Равномерная выборка:")
print(a)
print()
print("Нормальная выборка:")
print(b)
print()
print("Статистика для равномерной выборки:")
print("Среднее:", numpy.mean(a))
print("Мода:", stats.mode(a)[0])
print("Медиана:", numpy.median(a))
print("Минимум:", numpy.min(a))
print("Максимум:", numpy.max(a))
print("Стандартное отклонение:", numpy.std(a, ddof = 1)) #ddof=1 указывает на то, что мы вычисляем стандартное отклонение для выборки
print()
print("Статистика для нормальной выборки:")
print("Среднее:", numpy.mean(b))
print("Мода:", stats.mode(b)[0])
print("Медиана:", numpy.median(b))
print("Минимум:", numpy.min(b))
print("Максимум:", numpy.max(b))
print("Стандартное отклонение:", numpy.std(b, ddof = 1))
print()

aa = [1]*100 #Ожидаемые частоты
b = [0]*100 #Заготовка для наблюдаемых частот
#Воспользуемся равномерной выборкой из номера 4
for n in a:
    b[n] += 1
statistic, pvalue = scipy.stats.chisquare(b,aa)
print(f"p-value: {pvalue}")
if pvalue > 0.05:
    print("Распределение выборки равномерное")
else:
    print("Распределение выборки не равномерное")
