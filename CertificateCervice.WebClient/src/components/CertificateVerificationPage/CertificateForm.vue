<template>
    <form name="certificateForm" method="post" action="post">

        <h4>Бланк додавання сертифіката ковід</h4>

        <div className="input-field mt2">
            <label htmlFor="name" className="active">Введіть ім'я пацієнта:</label>
            <input type="text"
                   id="name"
                   name="name"
                   placeholder="Введіть ім'я пацієнта" />
        </div>
        <div className="input-field">
            <label htmlFor="surname" className="active">Введіть фамілію пацієнта:</label>
            <input type="text"
                   id="surname"
                   name="surname"
                   placeholder="Введіть фамілію пацієнта" />
        </div>
        <div className="input-field">
            <label htmlFor="date" className="active">Введіть дату народження:</label>
            <input type="date"
                   id="date"
                   name="birthdate" />
        </div>

        <h5>Відскануйте qr-код</h5>

        <div className="row">
            <div className="col">
                <div id="reader"></div>
            </div>
            <div className="col">
                <h4>SCAN RESULT</h4>
                <div id="result">Result Here</div>
            </div>
        </div>

        <button className="btn waves-effect waves-light" type="submit" id="submit" name="action">
            Відправити
            <i className="material-icons right">send</i>
        </button>

    </form>
</template>

<script>
    export default {
        name: 'CertificateForm',
        props: {
        }
    };
</script>

<style scoped>
    .mt2 {
        margin-top: 2rem;
    }
</style>