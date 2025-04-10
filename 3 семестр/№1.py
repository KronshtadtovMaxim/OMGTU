import numpy
def fix(matrix):
    for row in matrix:
        print(row)
    return ""
numpy.set_printoptions(precision=2, suppress=True)
array_2d = numpy.arange(10, 70, 2)
print("Массив: ")
print(array_2d)
matrix_2d = array_2d.reshape((6, 5))
print("Матрица: ")
print(fix(matrix_2d))


print("Транспонированная матрица: ")
matrixTran_2d = matrix_2d.transpose()
print(fix(matrixTran_2d))


matrixTran_2d = numpy.multiply(matrixTran_2d, 2.5)
matrixTran_2d[0] = matrixTran_2d[0] - 5
print("Умноженная и вычтенная матрица: ")
print(fix(matrixTran_2d.astype(int)))

print("Матрица B:")
matrix_2 = numpy.random.randint(0, 11, (6, 3))
print(fix(matrix_2))

vector_1 = numpy.sum(matrixTran_2d, axis=1)
vector_2 = numpy.sum(matrix_2, axis=0)
print("Вектор первой матрицы и его размер: ")
print(vector_1.astype(int), vector_1.size)
print("Вектор второй матрицы и его размер: ")
print(vector_2.astype(int), vector_2.size)

print("Матричное произведение: ")
print(fix(matrixTran_2d.dot(matrix_2).astype(int)))

print("Обновленная матрица А:")
matrix_1 = numpy.delete(matrixTran_2d, 3, axis=1)
print(fix(matrix_1.astype(int)))
for i in range(3):
    row = numpy.random.randint(10, 21, (matrix_2.shape[0], 1))
    matrix_2 = numpy.column_stack((matrix_2, row))
print("Обновленная матрица В: ")
print(fix(matrix_2))

print("Определитель матрицы A: ")
print(numpy.linalg.det(matrix_1))
print("Определитель матрицы B: ")
print(numpy.linalg.det(matrix_2))
if numpy.linalg.det(matrix_1) != 0:
    print("Обратная матрица А: ")
    print(fix(numpy.linalg.inv(matrix_1)))
if numpy.linalg.det(matrix_2) != 0:
    print("Обратная матрица B: ")
    print(fix(numpy.linalg.inv(matrix_2)))

print("Матрица А в 6ой степени:")
print(fix(numpy.linalg.matrix_power(matrix_1, 6)))
print("Матрица В в 14ой степени")
print(fix(numpy.linalg.matrix_power(matrix_2, 14)))

matrix = numpy.array([[2.3, 0,-3.4, -12], [2.6, 8.4, 0, -6], [1.3, 4.5, -17, 2], [1.8, 0, 15, 16]])
matrix_rovno = numpy.array([-14,0.4,-3.6,17.4])
vector_otv = numpy.linalg.solve(matrix, matrix_rovno)
print("Вектор х, являющийся решением СЛУ из 4го варианта: ")
print(vector_otv)
