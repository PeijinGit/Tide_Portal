<template>
    <div class="inner" :style="'width:${width}'">
        <slot></slot>
    </div>
</template>
<script>
export default{
    props:["width"]
}
</script>
<style lang="scss" scoped>
    .inner{
        width: 1200px;
        margin: auto;
        overflow: hidden;
        margin-top: 36px;
        padding-bottom: 20px; 
    }
</style>