# -*- coding: utf-8 -*-
"""
Created on Wed Aug  3 14:02:54 2022

@author: jonas
"""

import matplotlib.pyplot as plt
import numpy as np

# x axis values
x1 = [-20,-15,-10,-5,0,5,10,15,20]
x2 = [-30,-25,-20,-15,-10,-5,0,5,10]
# corresponding y axis values
y11 = [95.97,29.81,21.09,18.33,16.87,20.32,26.76,30.07,107.90]
y12 = [21.31,21.49,3.15,2.44,2.34,2.50,4.70,34.58,11.67] 
y13 = [76.31,52.40,19.68,16.51,21.03,15.18,32.08,45.94,108.76]

y21 = [28.87,21.96,20.54,18.49,19.16,17.07,15.85,17.29,37.25]
y22 = [2.39,2.18,2.48,2.14,2.17,2.18,2.74,2.84,20.46] 
y23 = [15.89,14.88,20.48,15.61,18.00,20.77,18.68,14.82,42.22]





fig, (ax1, ax2, ax3) = plt.subplots(1, 3)
fig.set_size_inches(9, 4)
fig.tight_layout()

ax1.plot(x1, y11, '-k')
ax1.plot(x2, y21, '--k')
ax1.set_xlim([-30,20])
ax1.set_ylim([10,110])
ax1.set_xticks(np.arange(-30, 21, 10))
# naming the y axis
ax1.set_ylabel('Accuracy (pixels)')
ax1.grid()

ax2.plot(x1, y12, '-k')
ax2.plot(x2, y22, '--k')
ax2.set_xlim([-30,20])
ax2.set_ylim([0,40])
ax2.set_xticks(np.arange(-30, 21, 10))
# naming the y axis
ax2.set_ylabel('Precision (pixels)')
ax2.grid()

ax3.plot(x1, y13, '-k', label = "horizontal")
ax3.plot(x2, y23, '--k', label = "vertical")
ax3.set_xlim([-30,20])
ax3.set_ylim([10,110])
ax3.set_xticks(np.arange(-30, 21, 10))
# naming the y axis
ax3.set_ylabel('Standard deviation precision (pixels)')
ax3.grid()
ax3.legend()

fig.text(0.5, -0.03, 'Head rotation (°)', ha='center')

fig.savefig('headRotation.png', dpi=300, bbox_inches = "tight")


