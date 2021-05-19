#Importing required libraries
import pandas as pd
import numpy as np
from sklearn.model_selection import KFold 
from sklearn.tree import DecisionTreeClassifier 
from sklearn.metrics import accuracy_score
 
#Loading the dataset
data = pd.read_csv('./Data/car.data')

from sklearn import preprocessing
le = preprocessing.LabelEncoder()
for column_name in data.columns:
	if data[column_name].dtype == object:
		data[column_name] = le.fit_transform(data[column_name])
	else:
		pass


y = data.iloc[: , 0]
X = data.iloc[:, 1:17]

# drop data row
X = X.replace((np.inf, -np.inf, np.nan), 0).reset_index(drop=True)

 
#Implementing cross validation
 
k = 10
kf = KFold(n_splits=k, random_state=None)
model = DecisionTreeClassifier()
 
acc_score = []
 
for train_index , test_index in kf.split(X):
    X_train , X_test = X.iloc[train_index,:],X.iloc[test_index,:]
    y_train , y_test = y[train_index] , y[test_index]
     
    model.fit(X_train,y_train)
    pred_values = model.predict(X_test)
     
    acc = accuracy_score(pred_values , y_test)
    acc_score.append(acc)
     
avg_acc_score = sum(acc_score)/k
 
print('accuracy of each fold - {}'.format(acc_score))
print('Avg accuracy : {}'.format(avg_acc_score))
