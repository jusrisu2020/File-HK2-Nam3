// id, name, age, school
const secCollec = document.getElementById('collecSec');
const txtId = document.getElementById('idbox');
const txtName = document.getElementById('namebox');
const txtAge = document.getElementById('agebox');
const txtSchool = document.getElementById('schoolbox');
const btnInsert = document.getElementById('insert');
const btnUpdate = document.getElementById('update');
const btnDelete = document.getElementById('delele');
const btnSelect = document.getElementById('select');

const usersDB = dataBase.collection('users');
// const userCollection = dataBase.collection('users');
// const ID = userCollection.doc(txtId.value);
//Thêm dữ liệu



btnInsert.addEventListener('click',e =>{
    e.preventDefault();
    usersDB.doc(txtId.value).set({
            Name:txtName.value,
            Age:txtAge.value,
            School:txtSchool.value,
        })
        .then(() => {console.log('Insert Success!');})
        .catch(error => {console.error(error)})
});

//Cập nhật dữ liệu
// btnUpdate.addEventListener('click',e =>{
//     e.preventDefault();
//     userCollection.doc(txtId.value).update({
//             Name:txtName.value,
//             Age:txtAge.value,
//             School:txtSchool.value,
//         })
//         .then(() => {console.log('Update Successful!');})
//         .catch(error => {console.error(error)})
// });


//Xoá dữ liệu trong các Field
btnDelete.addEventListener('click',e =>{
    e.preventDefault();
    userCollection.doc(txtId.value).delete({
    }).then(()=>{console.log('Delete Field Success!')})
});

btnSelect.addEventListener('click',e =>{
    e.preventDefault();
    userCollection.doc(txtId.value).get()
        .then(user =>{
            if(user.exists)
                console.log(user.data());
            else
                console.log('Not Load Data');
        })
        .catch(error=>{console.error(error);})
});