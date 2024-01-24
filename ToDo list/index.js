const ul = document.querySelector('ul');
const addbtn = document.querySelector('.addbtn');
let inputText = document.getElementById('input-text');
let editingTask = null;

addbtn.addEventListener('click', () => {
    if (inputText.value != '') {
        if (editingTask) {
            // Editing an existing task
            editingTask.querySelector('p').innerText = inputText.value;
            addbtn.innerText = 'ADD';
            editingTask = null;
        } else {
            let li = document.createElement('li');
            li.innerHTML = `<p>${inputText.value}</p>
                <div class="edit-delete-container">
                    <button class="edit-button">EDIT</button>
                    <button class="delete-button">DELETE</button>
                </div>`;
            ul.appendChild(li);
            setupEditDeleteButtons(li);
        }
        inputText.value = '';
    }
});



function setupEditDeleteButtons(li) {
    const editbtn = li.querySelector('.edit-button');
    const deletebtn = li.querySelector('.delete-button');
    const para = li.querySelector('p');

    deletebtn.addEventListener('click', e => {
        // e.target.parentElement.remove();
        e.target.parentElement.parentElement.remove();
        e.stopPropagation();
    });

    editbtn.addEventListener('click', () => {
        inputText.value = para.innerText;
        addbtn.innerText = 'SAVE';
        editingTask = li;
        inputText.focus();
    });
}

ul.addEventListener('click', e => {
    if (e.target.classList.contains('edit-button') || e.target.classList.contains('delete-button')) {
        setupEditDeleteButtons(e.target.closest('li'));
    }
});
