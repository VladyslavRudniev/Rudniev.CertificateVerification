<template>
    <div id="app">
        <Navbar />
        <CertificateForm />
</div>
</template>

<script>
    import Navbar from './components/header/Navbar.vue';
    import CertificateForm from './components/CertificateVerificationPage/CertificateForm.vue';

    export default {
        name: 'app',
        components: {
            Navbar,
            CertificateForm
        }
    };
</script>

<style>
</style>

