<template>
    <form name="certificateForm" method="post" action="post">

        <h4>Бланк додавання сертифіката ковід</h4>

        <div class="input-field mt2">
            <label for="name" class="active">Введіть ім'я пацієнта:</label>
            <input type="text"
                   id="name"
                   name="name"
                   placeholder="Введіть ім'я пацієнта" />
        </div>
        <div class="input-field">
            <label for="surname" class="active">Введіть фамілію пацієнта:</label>
            <input type="text"
                   id="surname"
                   name="surname"
                   placeholder="Введіть фамілію пацієнта" />
        </div>
        <div class="input-field">
            <label for="date" class="active">Введіть дату народження:</label>
            <input type="date"
                   id="date"
                   name="birthdate" />
        </div>

        <a class="waves-effect waves-light btn" @click="qrVisible=!qrVisible">далі</a>

        <template v-if="qrVisible">
            <h5>Відскануйте qr-код</h5>

            <div class="row">
                <div class="col">
                    <div id="reader"></div>
                </div>
                <div class="col">
                    <h4>SCAN RESULT</h4>
                    <div id="result">Result Here</div>
                </div>
            </div>

            <button class="btn waves-effect waves-light" type="submit" id="submit" name="action">
                Відправити
                <i class="material-icons right">send</i>
            </button>
        </template>

    </form>
</template>

<script>
    export default {
        name: 'CertificateForm',
        props: {
            qrVisible: Boolean
        }
    };
</script>

<style scoped>
    .mt2 {
        margin-top: 2rem;
    }
</style>