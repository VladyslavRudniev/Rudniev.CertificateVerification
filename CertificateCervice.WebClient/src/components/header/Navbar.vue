<template>
    <nav>
        <div class="nav-wrapper pl1">
            <a href="/" class="brand-logo">{{logoMsg}}</a>
        </div>
    </nav>
</template>

<script>
    export default {
        name: 'Navbar',
        props: {
            logoMsg:
            {
                type: String,
                require: true,
                default: "hello world"
            }
        }
        
    };
    
</script>

<style scoped>
    .pl1 {
        padding-left: 1rem;
    }
</style>