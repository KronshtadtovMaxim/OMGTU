import sympy as sp
import matplotlib.pyplot as plt
import numpy

def F(x):
    return 2/(sp.sin(x) + 4)
a = 3
b = 6
dx = 0.01
abc = (b-a)*dx
func = []
x = []
while(b != a):
    func.append(F(b))
    x.append(b)
    b = round(b-abc, 2) #float
plt.plot(x, func)
plt.xlabel('x', fontsize=12)
plt.ylabel('y', fontsize=12)
plt.title("F = 2/(sin(x)+4)")
plt.legend()
plt.show()

ax1 = plt.scatter(x, func, marker='.', color=(0.2, 0.4, 0.6))
ax1 = plt.title("F = 2/(sin(x)+4)")
ax1 = plt.xlabel('x')
ax1 = plt.ylabel('y')
ax1 = plt.grid(color='r', linestyle='--', linewidth=0.5, alpha=0.5) #цвет, тип, ширина, прозрачность
ax1 = plt.show()

a = numpy.random.randint(0, 100, 100)
b = numpy.random.normal(50, 100/6, 100) #normal
b = numpy.clip(numpy.round(b), 0, 100).astype(int) #округление
ax2 = plt.hist(a, bins=50, color='skyblue', edgecolor='black', alpha=0.7)
ax2 = plt.title('Гистограмма равномерного распределения')
ax2 = plt.xlabel('Значение')
ax2 = plt.ylabel('Частота')
ax2 = plt.show()

plt.hist(b, bins=50, color='skyblue', edgecolor='black', alpha=0.7)
plt.title('Гистограмма нормального распределения')
plt.xlabel('Значение')
plt.ylabel('Частота')
plt.show()

a = numpy.random.randint(1, 5, 50)
unique, counts = numpy.unique(a, return_counts=True)
dict = dict(zip(unique, counts))
ax3 = plt.figure(figsize=(10, 5))
ax3 = plt.pie(counts, labels=dict.keys(), colors=['red', 'blue', 'green', 'orange'])
ax3 = plt.title('Распределение чисел от 1 до 4 в выборке')
ax3 = plt.show()

plt.figure(figsize=(10, 5))
plt.bar(dict.keys(), dict.values(), color =['red', 'blue', 'green', 'orange'])
plt.xlabel('Числа от 1 до 4')
plt.ylabel('Частота')
plt.title('Распределение чисел от 1 до 4 в выборке')
plt.show()

x = numpy.linspace(-10, 10, 100) #Создает массив из 100 равномерно распределенных точек в диапазоне от -10 до 10.
y = numpy.linspace(-10, 10, 100)
x, y = numpy.meshgrid(x, y) #Создает двумерные массивы x и y, которые представляют собой сетку точек на плоскости

# Вычисляем значения функции z = (x - 4)^2 + (y - 2)^2
z = (x - 4)**2 + (y - 2)**2

# Создаем трехмерный график
fig = plt.figure()
ax4 = fig.add_subplot(111, projection='3d') #Добавляет трехмерную ось к фигуре. Параметры 111 указывают на расположение подграфика (1 строка, 1 столбец, первый подграфик), а projection='3d' указывает на трехмерную проекцию.

# Строим поверхность
surf = ax4.plot_surface(x, y, z, cmap='viridis', linewidth=0, antialiased=False) #cmap='viridis': Устанавливает цветовую карту для графика. viridis — это одна из предопределенных цветовых карт в Matplotlib.

#linewidth=0: Устанавливает ширину линии на 0, чтобы линии не отображались на поверхности.

#antialiased=False: Отключает сглаживание линий, что может ускорить отрисовку.

# Устанавливаем цвет линии на графике
ax4.contour(x, y, z, zdir='z', offset=-10, cmap='Reds') #zdir='z': Указывает, что контурные линии должны быть нарисованы в направлении оси z.

#=-10: Устанавливает смещение контурных линий по оси z на -10.

# Настройка осей и заголовка
ax4.set_xlabel('X')
ax4.set_ylabel('Y')
ax4.set_zlabel('Z')
ax4.set_title('График функции (x - 4)^2 + (y - 2)^2')

# Добавляем цветовую шкалу
fig.colorbar(surf, shrink=0.5, aspect=5)

# Отображаем график
plt.show()



# Создаем новую фигуру и сетку подграфиков
fig, axs = plt.subplots(2, 2, figsize=(12, 8))
fig.suptitle('Сетка графиков', fontsize=16)
# Добавляем существующие объекты графиков в соответствующие позиции
axs[0, 0].add_axes(ax1.figure.axes[0])
axs[0, 1].add_axes(ax2.figure.axes[0])
axs[1, 0].add_axes(ax3.figure.axes[0])
axs[1, 1].add_axes(ax4.figure.axes[0])

# Отображаем графики
plt.tight_layout()
plt.show()