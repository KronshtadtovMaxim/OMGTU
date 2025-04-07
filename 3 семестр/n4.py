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
y = x
ax1 = plt.plot(x, func)
ax1 = plt.xlabel('x', fontsize=12)
ax1 = plt.ylabel('y', fontsize=12)
ax1 = plt.title("F = 2/(sin(x)+4)")
ax1 = plt.show()

ax2 = plt.scatter(x, func, marker='.', color=(0.2, 0.4, 0.6))
ax2 = plt.title("F = 2/(sin(x)+4)")
ax2 = plt.xlabel('x')
ax2 = plt.ylabel('y')
ax2 = plt.grid(color='r', linestyle='--', linewidth=0.5, alpha=0.5)
ax2 = plt.show()

a = numpy.random.randint(0, 100, 100)
b = numpy.random.normal(50, 100/6, 100) #normal
b = numpy.clip(numpy.round(b), 0, 100).astype(int) #округление
afg = plt.hist(a, bins=50, color='skyblue', edgecolor='black', alpha=0.7)
afg = plt.title('Гистограмма равномерного распределения')
afg = plt.xlabel('Значение')
afg = plt.ylabel('Частота')
afg = plt.show()

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

x_3d = numpy.linspace(-10, 10, 100)
y_3d = numpy.linspace(-10, 10, 100)
x_3d, y_3d = numpy.meshgrid(x_3d, y_3d)
z_3d = (x_3d - 4) ** 2 + (y_3d - 2) ** 2

z = (x_3d - 4)**2 + (y_3d - 2)**2

fig = plt.figure()
ax4 = fig.add_subplot(projection='3d')

surf = ax4.plot_surface(x_3d, y_3d, z_3d, cmap='viridis', antialiased=False) #cmap='viridis': Устанавливает цветовую карту для графика. viridis — это одна из предопределенных цветовых карт в Matplotlib.

ax4.set_xlabel('X')
ax4.set_ylabel('Y')
ax4.set_zlabel('Z')
ax4.set_title('График функции (x - 4)^2 + (y - 2)^2')


plt.show()
styles = ['fivethirtyeight', 'ggplot', 'bmh']
for style in styles:
    plt.style.use(style)
    fig, axs = plt.subplots(2, 2, figsize=(14, 10))

    axs[0,0].plot(x, func)
    axs[0,0].set_xlabel('x', fontsize=12)
    axs[0,0].set_ylabel('y', fontsize=12)
    axs[0,0].set_title("F = 2/(sin(x)+4)")


    axs[0, 1].scatter(x, func, marker='.', color=(0.2, 0.4, 0.6), label='Scatter')
    axs[0, 1].set_title("F = 2/(sin(x)+4)")
    axs[0, 1].set_xlabel('x')
    axs[0, 1].set_ylabel('y')
    axs[0, 1].grid(color='r', linestyle='--', linewidth=0.5, alpha=0.5)
    axs[0, 1].legend()


    axs[1,0].pie(counts, labels=dict.keys(), colors=['red', 'blue', 'green', 'orange'])
    axs[1,0].set_title('Распределение чисел от 1 до 4 в выборке')

    ax4 = fig.add_subplot(2, 2, 4, projection='3d')
    surf = ax4.plot_surface(x_3d,y_3d, z_3d, cmap='viridis', linewidth=0, antialiased=False)
    ax4.contour(x, y, z, zdir='z', offset=-10, cmap='Reds')
    ax4.set_xlabel('X')
    ax4.set_ylabel('Y')
    ax4.set_zlabel('Z')
    ax4.set_title('График функции (x - 4)^2 + (y - 2)^2')
    fig.colorbar(surf, shrink=0.5, aspect=5, ax=ax4)


    fig.suptitle('Сетка из 4 графиков', fontsize=16)

    plt.tight_layout()
    plt.show()

