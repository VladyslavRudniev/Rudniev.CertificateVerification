<template>
    <nav>
        <div className="nav-wrapper pl2">
            <a href="/" className="brand-logo">Test task</a>
        </div>
    </nav>
</template>

<script>
    export default {
        name: 'Navbar',
        props: {
        }
    };
</script>

<style scoped>
    .pl2 {
        padding-left: 2rem;
    }
</style>